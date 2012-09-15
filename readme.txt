Notes: 
1) This component uses mimeTeX 1.7.4 (http://www.forkosh.com/mimetex.html) to parse
   LaTeX code.
2) This component only supports HTML Help 1.x and Website output.

Requirements:
 Sandcastle Help File Builder v1.9.4

Instructions
From the zip file:
1. Download the zip file from http://github.com/cuda/latex-sandcastle/downloads) that matches your CPU architecture.
2. Place the files from the zip file into the Sandcastle Help File Builder (SHFB) Components and Plug-Ins directory.
   This directory differs depending on your OS.
   Windows Vista, 7, & 8: %ProgramData%\EWSoftware\Sandcastle Help File Builder\Components and Plug-Ins
   Windows XP: %ALLUSERSPROFILE%\Application Data\EWSoftware\Sandcastle Help File Builder\Components and Plug-Ins
3. In your SHFB configuration file add the "LaTeX Build Component" to the ComponentConfigurations property of the build section.
4. Add <latex> tags to your XML comments.  The <latex> tag must be placed inside regular XML comment tags.
   Example: ///<summary><latex>f(x)=x^2</latex></summary>
   For complex LaTeX code, it should be placed in a CDATA tag, i.e. <latex><!CDATA[f(x)=x^2]]></latex>
5. Run SHFB as usual.   

From Source:
1. Set the CPU platform for the mimetex project to match your platform.
2. Build the LatexBuildComponent project.
3. From LatexBuildComponent\bin\Release, place the to DLLs and LatexBuildComponent.components into the Sandcastle Help File Builder (SHFB) Components and Plug-Ins directory.
   This directory differs depending on your OS.
   Windows Vista, 7, & 8: %ProgramData%\EWSoftware\Sandcastle Help File Builder\Components and Plug-Ins
   Windows XP: %ALLUSERSPROFILE%\Application Data\EWSoftware\Sandcastle Help File Builder\Components and Plug-Ins
4. In your SHFB configuration file add the "LaTeX Build Component" to the ComponentConfigurations property of the build section.
5. Add <latex> tags to your XML comments.  The <latex> tag must be placed inside regular XML comment tags.
   Example: ///<summary><latex>f(x)=x^2</latex></summary>
   For complex LaTeX code, it should be placed in a CDATA tag, i.e. <latex><!CDATA[f(x)=x^2]]></latex>
6. Run SHFB as usual.

