# Minecraft Map Editor
Map Editor for Minecraft JAVA Edition
- Use with [NBTExplorer](https://github.com/jaquadro/NBTExplorer)
## Usage
### How to create a map:
- Enter your minecraft world, make a filled map.
- IMPORTANT: The map must be LOCKED!
### How to open an existing map:
- Run NBTExplorer, open map_#.dat in .minecraft\saves&#92;&#60;World Name>\data\
- Copy the entire value of map_#.dat\data\colors in Text View.
- Run MapEditor. Click File > Open.
- Paste the value that just copied then click OK or press Enter.
- Done. Now you can paint the map.
### How to apply an edited map:
- Click File > Build. The colors value of the map will be saved to your clipboard as text.
- Run NBTExplorer, open map_#.dat in .minecraft\saves&#92;&#60;World Name>\data\
- Open map_#.dat\data\colors in Text View. Clear the original value then paste the new value.
- Click Save button or press Ctrl+S to save.
- Done. The edited map is saved to your world. Enter or re-enter your world to see your edited map.
### How to get my edited map:
- Use command: /give @p filled_map{map:#}
- &#35; stands for the map number
### The canvas suddenly becomes empty:
- Click View > Redraw > Map to redraw your map.
