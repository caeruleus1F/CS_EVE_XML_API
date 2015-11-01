# CS_EVE_XML_API
A convenient, light-weight dynamically-linked library in C# that allows other developers to easily interface with the EVE Online API.
All endpoint information used to build the library was obtained from http://wiki.eve-id.net/API and can be used as reference documentation.

All method calls return XmlDocument which requires importing System.Xml, except for the /image/ endpoints which return Image objects requiring adding the System.Drawing.dll assembly and adding the System.Drawing namespace.

Compiled binary:

https://www.dropbox.com/s/yb5mfj9oryluni3/CS-EVE-XML-API.zip?dl=0

Usage:

1. Download and extract the library into a folder of your choice using the link provided above.

2. In your C# project, Add a Reference to the assembly.

3. Add "using CS_EVE_XML_API;".

4. The EVEXMLAPI class is implemented as a thread-safe singleton. Example call:

XmlDocument xml = EVEXMLAPI.getInstance().Characters(keyID, vCode);

Image img = EVEXMLAPI.getInstance().ImageCharacter(characterID, size);
