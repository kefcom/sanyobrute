# sanyobrute
A brute force pin guesser for the sanyo prox trax (PLC-XW56) projector
Made in vb.net

# Making connection
Use a USB to serial cable and wire to the projector's serivce port as shown in this scheme:
![wiring schematic](https://github.com/kefcom/sanyobrute/blob/master/wiring.png "Wiring schematic")
[source](http://www.herngwei.com/download/sanyo/RS232/RS232_XU115.pdf)

![pinouts](https://github.com/kefcom/sanyobrute/blob/master/pinouts.png "Pinouts")
[source](https://studylib.net/doc/18269329/eight-pin-mini---din-connector-pin--outs)


# using the software
- Start the program
- Change port to whatever port the usb-serial is using
- Click on 'open port'
- If everything goes right, you can now power on the projector by pressing the  'projector on' button.
When that works, navigate to the pin input window
- if you are resuming a previous attempt, input the last known number, if not, enter 0000
- navigate to the submit button
- Enter the same number in the program's 4 digit boxes
- Press start

The software should now start guessing the pin.

If the pin is found, the software will not stop. You will notice the projector is stuck in a change pin menu.

Stop the program and change to a new pin.

# screenshot
![scrfeenshot](https://github.com/kefcom/sanyobrute/blob/master/screenshot.png "Pinouts")
