Public Class frmOdb2

    Public strData As String
    Public blnStartStop As Boolean
    Public strCMD_PID As String
    Public blnDataLogger As Boolean

    Dim path As String = "ODB2_DataLogger.txt"
    Dim sw As IO.StreamWriter

    Public Structure engine
        Dim date_time As String
        Dim RPM As Double
        Dim Speed As Double
        Dim TempCool As Double
        Dim BatteryVoltage As String
        Dim Device_description As String
        Dim Version_ID As String
        Dim Protocol As String
    End Structure

    Public Megane2 As engine

    Public PIDs As New Collection()


    Private Sub frmOdb2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

        PIDs.Add("0105", "EngineCoolantTemperature")
        PIDs.Add("010C", "EngineRPM")
        PIDs.Add("010D", "VehiculeSpeed")

        PIDs.Add("AT@1", "DeviceDescription")
        PIDs.Add("ATI", "VersionID")
        PIDs.Add("ATDP", "Protocol")
        PIDs.Add("ATRV", "BatteryVoltage")

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX


        With SerialPort1
            .PortName = "COM3"
            .BaudRate = 38400
            .Parity = IO.Ports.Parity.None
            .StopBits = IO.Ports.StopBits.One
            .DataBits = 8

            If .IsOpen Then
                .Close()
                .Open()
            Else
                .Open()
            End If

        End With

        With Timer1
            .Interval = 50  'up to 20 ms 
        End With
        rd50ms.Checked = True

        Timer2.Interval = 1000 ' 1 s

        blnStartStop = True

        cbRTC.Checked = True
        cbRPM.Checked = True
        cbTemp.Checked = True
        cbSpeed.Checked = True

    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

        If blnStartStop = True Then

            With SerialPort1

                If .IsOpen Then
                    .Close()
                    .Open()
                Else
                    .Open()
                End If
            End With

            strCMD_PID = PIDs("DeviceDescription")
            SerialPort1.Write(strCMD_PID & vbCr)
            Timer1.Enabled = True
            Timer1.Start()
            btnConnect.Text = "Close"
            blnStartStop = False

        ElseIf blnStartStop = False Then
            Timer1.Stop()
            If SerialPort1.IsOpen Then SerialPort1.Close()
            btnConnect.Text = "Start Connect"
            blnStartStop = True
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Timer1.Stop()

        'If btnConnect.BackColor = System.Drawing.SystemColors.Control Then
        '    btnConnect.BackColor = System.Drawing.Color.Yellow

        'ElseIf btnConnect.BackColor = System.Drawing.Color.Yellow Then
        '    btnConnect.BackColor = System.Drawing.SystemColors.Control
        'End If

        strData = SerialPort1.ReadExisting
        If Len(strData) > 5 Then strData = Mid$(strData, InStr(strData, vbCr) + 1, Len(strData) - 7)


        If strCMD_PID = PIDs("DeviceDescription") Then
            lblDescription.Text = strData
            Megane2.Device_description = strData
            strCMD_PID = PIDs("VersionID")
            SerialPort1.Write(strCMD_PID & vbCr)
            Timer1.Start()
        ElseIf strCMD_PID = PIDs("VersionID") Then
            lblID.Text = "Version ID: " & strData
            Megane2.Version_ID = strData
            strCMD_PID = PIDs("Protocol")
            SerialPort1.Write(strCMD_PID & vbCr)
            Timer1.Start()
        ElseIf strCMD_PID = PIDs("Protocol") Then
            lblProtocol.Text = "Protocol: " & strData
            Megane2.Protocol = strData
            strCMD_PID = PIDs("BatteryVoltage")
            SerialPort1.Write(strCMD_PID & vbCr)
            Timer1.Start()
        ElseIf strCMD_PID = PIDs("BatteryVoltage") Then
            lblVolt.Text = "Battery voltage: " & strData
            Megane2.BatteryVoltage = strData
            strCMD_PID = PIDs("EngineRPM")
            SerialPort1.Write(strCMD_PID & vbCr)
            Timer1.Start()
        ElseIf strCMD_PID = PIDs("EngineRPM") Then
            'xxxxxxxxxxxxxxxxxxxxxxx
            strData = "41 0C 16 FC"
            strData = ((strData.Remove(0, 5)).Trim(" "))
            Megane2.RPM = Val("&H" + strData) / 4
            strData = (Megane2.RPM).ToString
            'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            lblRPM.Text = "Engine RPM: " & strData & " rpm"
            strCMD_PID = PIDs("VehiculeSpeed")
            SerialPort1.Write(strCMD_PID & vbCr)
            Timer1.Start()
        ElseIf strCMD_PID = PIDs("VehiculeSpeed") Then
            'xxxxxxxxxxxxxxxxxxxxxxx
            strData = "41 0D 24"
            strData = (strData.Remove(0, 5)).Trim
            Megane2.Speed = Val("&H" + strData)
            strData = (Megane2.Speed).ToString
            'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            lblSpeed.Text = "Vehicule speed: " & strData & " km/h"
            strCMD_PID = PIDs("EngineCoolantTemperature")
            SerialPort1.Write(strCMD_PID & vbCr)
            Timer1.Start()
        ElseIf strCMD_PID = PIDs("EngineCoolantTemperature") Then
            'xxxxxxxxxxxxxxxxxxxxxxx
            strData = "41 05 52"
            strData = (strData.Remove(0, 5)).Trim
            Megane2.TempCool = Val("&H" + strData) - 40
            strData = (Megane2.TempCool).ToString
            'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
            lblTemp.Text = "Temperature coolant: " & strData & " °C"
            strCMD_PID = PIDs("EngineRPM")
            SerialPort1.Write(strCMD_PID & vbCr)

            '*******************************************************************************
            If blnDataLogger = True Then

                ' This text is added only once to the file.
                If IO.File.Exists(path) = False Then
                    ' Create a file to write to.
                    sw = IO.File.CreateText(path)
                    sw.AutoFlush = True

                    Megane2.date_time = Date.Today & " " & TimeOfDay

                    sw.WriteLine("###############################################################")
                    sw.WriteLine("Date Time: " & Megane2.date_time)
                    sw.WriteLine("Device Description: " & Megane2.Device_description)
                    sw.WriteLine("Version ID: " & Megane2.Version_ID)
                    sw.WriteLine("Protocol: " & Megane2.Protocol)
                    sw.WriteLine("Battery Voltatage: " & (Megane2.BatteryVoltage))
                    sw.WriteLine("###############################################################")

                    sw.WriteLine("Date Time,  Coolant Temperature, Vehicule speed, Engine RPM")
                    sw.Flush()
                    sw.Close()
                End If

                ' This text is always added, making the file longer over time
                ' if it is not deleted.
                sw = IO.File.AppendText(path)

                sw.WriteLine(
                               Date.Today & " " & TimeOfDay & "," & Megane2.TempCool.ToString() & "," _
                                & Megane2.Speed.ToString() & "," _
                                & Megane2.RPM.ToString()
                                    )
                sw.Flush()
                sw.Close()

            End If
            '************************************************************************************
            My.Application.DoEvents()
            '************************************************************************************
            Timer1.Start()
        End If


    End Sub


    Private Sub rd50ms_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd50ms.CheckedChanged
        Timer1.Interval = 50
    End Sub

    Private Sub rd100ms_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd100ms.CheckedChanged
        Timer1.Interval = 100
    End Sub

    Private Sub rd500ms_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd500ms.CheckedChanged
        Timer1.Interval = 500
    End Sub

    Private Sub rd1s_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rd1s.CheckedChanged
        Timer1.Interval = 1000
    End Sub

    Private Sub btDump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDump.Click


        If blnStartStop = False Then
            btDump.Enabled = False
            blnDataLogger = True
        Else
            MsgBox("You should first connect the device to your computer!", vbCritical)
        End If


    End Sub

    Private Sub btReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReset.Click

        If blnStartStop = True Then

            With SerialPort1

                If .IsOpen Then
                    .Close()
                    .Open()
                Else
                    .Open()
                End If
            End With

            If MsgBox("Do you really want to erase the trouble diagnostic codes??" & vbLf _
                    & "(Ignition key to ON, but vehicule not running!!)" & vbLf _
                   & "you will: " & vbLf _
                   & vbTab & "Reset the number of trouble codes" & vbLf _
                   & vbTab & "Erase any diagnostic trouble codes" & vbLf _
                   & vbTab & "Erase all oxygen sensor test data" & vbLf _
                   & vbTab & "... .", vbYesNo) = MsgBoxResult.Yes Then

                'SerialPort1.Write("04" & vbCr) ' Mode 04: clear trouble codes and stored values

                Timer2.Enabled = True
                Timer2.Start()
            End If

        Else
            MsgBox("You should first disconnect the device from your computer!" & vbLf _
                   & "Ignition key to ON, but vehicule not running!!", vbCritical)
        End If


    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        Timer2.Stop()

        strData = SerialPort1.ReadExisting

        If (Mid$(strData, InStr(strData, vbCr) + 1, 2) = "44") Then
            MsgBox("Mode 04 done succesfully!! ", vbExclamation)
        End If

        If SerialPort1.IsOpen Then SerialPort1.Close()

    End Sub
End Class
