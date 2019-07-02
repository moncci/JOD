using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace JOD.Writer.Models.com
{
    public class OfficeFontFaceDecls
    {
        [XmlElement(WriterKeyword.style_font_face)]
        public List<StyleFontFace> style_font_face { get; set; } = new List<StyleFontFace>();

        public OfficeFontFaceDecls()
        {
            
        }

        public void CreateIni()
        {
            style_font_face.Clear();
            style_font_face.Add(new StyleFontFace() { style_name = "Mangal1", svg_font_family = "Mangal" });
            style_font_face.Add(new StyleFontFace() { style_name = "Liberation Serif", svg_font_family = "'Liberation Serif'", style_font_family_generic = "roman", style_font_pitch = "variable" });
            style_font_face.Add(new StyleFontFace() { style_name = "Liberation Sans", svg_font_family = "'Liberation Sans'", style_font_family_generic = "swiss", style_font_pitch = "variable" });
            style_font_face.Add(new StyleFontFace() { style_name = "Mangal", svg_font_family = "Mangal", style_font_family_generic = "system", style_font_pitch = "variable" });
            style_font_face.Add(new StyleFontFace() { style_name = "Microsoft YaHei", svg_font_family = "'Microsoft YaHei'", style_font_family_generic = "system", style_font_pitch = "variable" });
            style_font_face.Add(new StyleFontFace() { style_name = "SimSun", svg_font_family = "SimSun", style_font_family_generic = "system", style_font_pitch = "variable" });
        }
    }
}
