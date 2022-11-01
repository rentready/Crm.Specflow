namespace Vermaat.Crm.Specflow
{
    public interface ICrmTestingContext
    {
        CommandProcessor CommandProcessor { get; set; }
        RecordBuilder RecordBuilder { get; }
        AliasedRecordCache RecordCache { get; }
        TableConverter TableConverter { get; }

        bool IsTarget(string target);
    }
}