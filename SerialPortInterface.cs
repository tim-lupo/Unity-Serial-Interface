/*

Tim Lupo
http://timlupo.com
Copyright (c) 2016

*/


using System.IO.Ports;

namespace SerialPortInterface {

	public class SerialPortInterface {

		/** Instructions for Use:
		
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

		*/

		public SerialPorts(string serialPortID, int serialRefreshRate) {
			updateSerial(serialPortID, serialRefreshRate);
		}

		public SerialPortInterface serial;

		public string[] getPorts() {
			string[] ports = SerialPort.GetPortNames();
			if (ports.Length > 0)
				return ports;
			else
				return null;
		}

		public string getDefaultPort() {
			string[] ports = SerialPort.GetPortNames();
			if (ports.Length > 0)
				return ports[0];
			else
				return null;
		}

		public void updateSerial(string serialPortID, int serialRefreshRate) {
			serial = new SerialPort (serialPortID, serialRefreshRate);
			openPorts();
		}

		public void serialWrite(string content) {
			openPorts();
			serial.Write(content);
		}

		public string serialRead() {
			openPorts();
			string input = serial.ReadLine();
			serial.BaseStream.Flush();
			return input;
		}

		public void openPorts() {
			if (serial.IsOpen == false)
				serial.Open();
		}

		public void closePorts() {
			if (serial.IsOpen == true)
				serial.Close();
		}
	}
}