# Testing program for Water Level Sensor DYP-L023MUW
 
 This program decodes the bytes coming out of the sensor and writes them to console.
 
 COM 7 is set in the code. Probably differs based on the USB module you are using.
 Settings: 9600 - 8N1
 
 ## Sensor Pinout
 
 1. Red - VCC (2.8v - 5v) - 3.3 is fine.
 2. Black - Ground
 3. Yellow - Sensor TX (Goes to Reader RX)
 4. White - Sensor RX (Goes to Reader TX) 

Haven't checked what voltages are coming out of 
 
 ## References
 - https://www.dypcn.com/uploads/L02-Output-Interfaces.pdf
 - https://www.dypcn.com/uploads/L02-Datasheet1.pdf
 
