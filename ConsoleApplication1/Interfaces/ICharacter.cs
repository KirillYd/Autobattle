namespace ConsoleApplication1.Interfaces
{
    public interface ICharacter
    {
        BodyPart head { get; set; }
        BodyPart chest { get; set; }
        BodyPart stomach { get; set; }
        BodyPart leftArm { get; set; }
        BodyPart leftLeg { get; set; }
        BodyPart rightArm { get; set; }
        BodyPart rightLeg { get; set; }
    }
}