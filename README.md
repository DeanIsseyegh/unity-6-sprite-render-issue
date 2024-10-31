# Instructions

Start project up and open "SampleScene.unity".

Play the scene.

Notice how as the camera moves, the sprites change, even though the animations on them are only changing some material properties.

![](https://github.com/DeanIsseyegh/unity-6-sprite-render-issue/blob/main/Unity6SpriteIssue.gif)

# Related Forum Posts

Related forum bug reports I've found:

https://discussions.unity.com/t/shader-bug-damage-flash-shader/1545591
https://discussions.unity.com/t/animating-material-property-causes-issues-with-2d-renderer/1539929

# Underlying issue

When you have multiple different sprites with animations on them changing their material properties, the sprite renderer bugs out and will show the wrong the sprite. 

Sometimes changing the camera angle/position (in both the game view with the main camera, or just in the scene preview navigation area.

This is quite a serious issue as it is very common for animations to update sprite properties.


# Sample project details

We have two basic sprites using Sprite-Lit-Default shaders, with animations on them that changes some material properties on them.

I also added another two identical sprites using a custom shader to show that this issue occurs for both Sprite-Lit-Default and for custom shaders.

