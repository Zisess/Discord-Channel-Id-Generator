
# Readme for ChannelIdGenerator

This code implements a method `ChannelIdGenerator(string Id)` in C# that generates a Discord channel ID using the Discord API.

## Inputs
- `Id`: a string, the recipient ID for the channel.

## Outputs
- The generated channel ID, which is stored in the global variable `channel_id`.

## How it works

The method makes a `POST` request to the Discord API with the recipient ID in the request body. The request header includes the authorization token.

The response from the API is then read and processed to extract the generated channel ID, which is stored in the global variable `channel_id`.

In case of any exceptions, the exception message is printed to the console.

## Limitations

It is assumed that the authorization token is already stored in the global variable `token`. If this is not the case, the method will produce an error.

## Conclusion

This method provides a simple way to generate a Discord channel ID using the Discord API. However, it is important to ensure that the necessary authorization is set up before using the method.

<p align="center">
  <img width="900" height="240" src="https://github.com/Zisess/Discord-Channel-Id-Generator/blob/main/Pictures/image.png?raw=true">
</p>


