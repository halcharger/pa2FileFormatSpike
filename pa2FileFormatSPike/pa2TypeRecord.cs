
namespace pa2FileFormatSPike
{
    interface Pa2Record
    {
        Pa2Type RecordType { get; }
        int LineNumber { get; set; }
    }

    public enum Pa2Type
    {
        Type0, 
        Type1, 
        Type2, 
        Type3, 
        Type4, 
        Type5, 
        Type6, 
        Type8, 
        Type9, 
        TypeB, 
        TypeC, 
        TypeE, 
        TypeR, 
        TypeS, 
        TypeV, 
        TypeX,
        TypeY, 
        TypeZ
    }
}
