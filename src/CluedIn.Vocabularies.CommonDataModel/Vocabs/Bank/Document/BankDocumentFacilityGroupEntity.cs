using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankDocumentFacilityGroupEntityVocabulary : SimpleVocabulary
    {
        public BankDocumentFacilityGroupEntityVocabulary()
        {
            VocabularyName = "Bank Document Facility Group Entity";
            KeyPrefix = "commonDataModel.bankdocumentfacilitygroupentity";
            KeySeparator = ".";
            Grouping = "/BankDocumentFacilityGroupEntity";

            AddGroup("BankDocumentFacilityGroupEntity Details", group =>
            {
                FacilityGroup = group.Add(new VocabularyKey(nameof(FacilityGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FacilityGroup { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}