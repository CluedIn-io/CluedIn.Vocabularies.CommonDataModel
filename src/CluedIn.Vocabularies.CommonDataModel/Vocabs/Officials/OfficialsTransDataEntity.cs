using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OfficialsTransDataEntityVocabulary : SimpleVocabulary
    {
        public OfficialsTransDataEntityVocabulary()
        {
            VocabularyName = "Officials Trans Data Entity";
            KeyPrefix = "commonDataModel.officialstransdataentity";
            KeySeparator = ".";
            Grouping = "/OfficialsTransDataEntity";

            AddGroup("OfficialsTransDataEntity Details", group =>
            {
                OfficialSession = group.Add(new VocabularyKey(nameof(OfficialSession), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportType = group.Add(new VocabularyKey(nameof(ReportType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Module = group.Add(new VocabularyKey(nameof(Module), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Warehouse = group.Add(new VocabularyKey(nameof(Warehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssociationWithWarehouse = group.Add(new VocabularyKey(nameof(AssociationWithWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmployeeName = group.Add(new VocabularyKey(nameof(EmployeeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Title = group.Add(new VocabularyKey(nameof(Title), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey OfficialSession { get; private set; }
        public VocabularyKey ReportType { get; private set; }
        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey Module { get; private set; }
        public VocabularyKey AccountRelation { get; private set; }
        public VocabularyKey Warehouse { get; private set; }
        public VocabularyKey AssociationWithWarehouse { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey EmployeeName { get; private set; }
        public VocabularyKey Title { get; private set; }
    }
}