using Level_18___Classes.Enums;
namespace Level_18___Classes.Classes;

public class Arrow
{
    public double ShaftLength { get; init; } = 0;
    public ArrowheadTypes ArrowheadType { get; init; } = 0;
    public FletchingTypes FletchingType { get; init; } = 0;

    public double Cost => (double)ArrowheadType + (double)FletchingType + (ShaftLength * 0.05);

    public Arrow(double shaftLength, ArrowheadTypes arrowheadType, FletchingTypes fletchingType)
    {
        ShaftLength = shaftLength; 
        ArrowheadType = arrowheadType; 
        FletchingType = fletchingType;
        
    }

    public static Arrow CreateEliteArrow() => new Arrow(95, ArrowheadTypes.Steel, FletchingTypes.Plastic);
    public static Arrow CreateBeginnerArrow() => new Arrow(75, ArrowheadTypes.Wood, FletchingTypes.Goose);
    public static Arrow CreateMarksmanArrow() => new Arrow(60, ArrowheadTypes.Steel, FletchingTypes.Goose);

}