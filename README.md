# PS4Lib
dynamic link library to create RTMs for PS4

## Usage
You need [PS4API.bin](https://github.com/BISOON/ps4-api-server/releases/download/1.0/PS4API.bin) server payload in order to use this library.

## A Brief Examples:

Instantiate the PS4API object:
```C#
PS4API PS4 = new PS4API();
```

Connect to target:
```C#
PS4.ConnectTarget("192.168.0.0");
```

Disconnect from target:
```C#

PS4.DisconnectTarget();
```

Attach to game process:
```c#

PS4.AttachProcess();
```
Detach Process:
```C#
PS4.DetachProcess();
```
Notify:
```C#

PS4.Notify(222, "Hello World!");
```
Write to memory:
```c#
PS4.SetMemory(0x0000000000000000, new byte[]{0x00,0x00});
```
Read from memory:
```C#
byte[] buffer = PS4.GetBytes(0x0000000000000000, 8);
```
GUI:
<p align="center">
<img alt=".." src="https://gyazo.com/1edafe027d99172e27b6427d1b2e549d.png"/>
</p>
