SetWorkingDir %A_ScriptDir%  ; Ensures a consistent starting directory.
#NoEnv
#MaxHotkeysPerInterval 99000000
#HotkeyInterval 99000000
#KeyHistory 0
ListLines Off
Process, Priority, , A
SetBatchLines, -1
SetKeyDelay, -1, -1
SetMouseDelay, -1
SetDefaultMouseSpeed, 0
SetWinDelay, -1
SetControlDelay, -1
SendMode Input



#IfWinActive, Diablo III
#maxthreadsperhotkey 10
$*MButton::
	toggle := !toggle
	if GetKeyState("f", "P")
		send {F Up}
	loop
	{
		If !(toggle)
			break
		else {
			if !GetKeyState("Alt", "P") {
				MouseClick, left
				sleep, 200
			}
			else {
				if !GetKeyState("f", "P")
					send {F Down}
				}
			}
	}
return
