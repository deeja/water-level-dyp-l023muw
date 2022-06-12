# Displaying of values for Water Level Sensor L023MUW and Distance Sensor AO121AU 
 
 This program decodes the bytes coming out of the sensor and writes them to console.
 
 COM 7 is set in the code. Probably differs based on the USB module you are using.
 Settings: 9600 - 8N1
 
 ## Sensor Pinout
 
 The TX/RX wires can differ between sensor types.


 ### L023MUW
 1. Red - VCC (2.8v - 5v) 
 2. Black - Ground
 3. Yellow - UART TX (Goes to Reader RX)
 4. White - UART RX (Goes to Reader TX)

 ### A0121AU
 1. Red - VCC (2.8v - 5v) 
 2. Black - Ground
 3. Yellow - UART RX (Goes to Reader TX)
 4. White - UART TX (Goes to Reader RX)


 
 ## References
 - https://www.dypcn.com/uploads/L02-Output-Interfaces.pdf
 - https://www.dypcn.com/uploads/L02-Datasheet1.pdf
 
