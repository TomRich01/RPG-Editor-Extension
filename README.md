# RPG-Editor-Extension
Welcome to the GitHub repo for the RPG Editor Extension (Unity), a designer tool to quickly create content from which a programmer can implement into a game. The project is inspired by the Skyrim/Fallout Creation Kits but for Unity.


## How Does it work?
Take creating a key for instance. First, you'll create an asset called "Key", name the key and provide a model for the key.

Your programmer (or you) will come in and hook the key up by calling the key into the script and then heading toward the selected IDE.

In the IDE, they'll do something like:
```
public CreateKeyEditor keyItem;

// Something like this
if (keyItem.name == "Key to" + doorName) {
  // Do something like open door
} else {
  //say the door is locked
}
```
The programmer will probably want to customize the object/asset to the game standard, which is why the asset is created to be as modular as I can make possibly.

### Community Help
Interested in using the plugin or wanting to help improve it? Go ahead! I'm happy for the help :)

The trello link for new features/bugs/etc., can be found here: https://trello.com/b/AOWroebf/rpg-editor-extension-unity
