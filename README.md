# Unity_Joystick_Publisher
Publishes joystick values from wired Xbox One controller

Use Joystick_Publisher scene.
Scene displays Xbox One controller buttons and highlights the buttons pressed.

1. Start rosbridge on linux device
2. Navigate to the JoyPublisher gameobject in Unity and enter the appropriate Ros Bridge Server URL
3. Press play in Unity
4. Joy data is published to a topic named Joystick_Inputs

Joystick_Publisher.mkv is a video showing the data transfer from Unity to ROS.
