# Arduino-Mouse Communication
Simple serial port integration with C#. Mainly functions as Arduino interface for Unity3D and other C# applications.

#Setup
1. Navigate to Edit > Project Settings > Player Settings
2. Select "PC, Mac, & Linux Standalone" and go to Other Settings
3. Under Optimization, make sure "Api Compatibility Level" is set to ".NET 2.0" (NOT Subset!)
4. Add "using SerialCommunication" to the top
5. Create a New SerialPorts Object
		SerialPorts object = new SerialPorts(string serialPortID, int serialRefreshRate);
6. Declare a serialPortID and serialRefreshRate with method updateSerial
  	object.updateSerial(string serialPortID, int serialRefreshRate);
7. Access read/write/close serial permissions from given objects
  	string read = object.serialRead();
		object.serialWrite(string input);
		object.closePorts();

# License
Copyright (c) 2016 Tim Lupo

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
