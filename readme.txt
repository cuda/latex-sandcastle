Requirements:
 Sandcastle Help File Builder v1.9.3.4 Beta 2

Instructions:
1. Place the three files from the binary directory of the zip file into the Sandcastle Help File Builder (SHFB) BuildComponents directory.
   This directory differs depending on your OS.
   Vista: %ProgramData%\EWSoftware\Sandcastle Help File Builder\Build Components
   Windows XP: %ALLUSERSPROFILE%\Application Data\EWSoftware\Sandcastle Help File Builder\Build Components
2. In your SHFB configuration file add the "LaTeX Build Component" to the ComponentConfigurations property of the build section.
3. Add <latex> tags to your XML comments.  The <latex> tag must be placed inside regular XML comment tags.
   Example: ///<summary><latex>f(x)=x^2</latex></summary>
   For complex LaTeX code, it should be placed in in CDATA tag, i.e. <latex><!CDATA[f(x)=x^2]]></latex>
4. Run SHFB as usual.
