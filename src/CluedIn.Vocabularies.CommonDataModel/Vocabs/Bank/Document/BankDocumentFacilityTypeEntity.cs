using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankDocumentFacilityTypeEntityVocabulary : SimpleVocabulary
    {
        public BankDocumentFacilityTypeEntityVocabulary()
        {
            VocabularyName = "Bank Document Facility Type Entity";
            KeyPrefix = "commonDataModel.bankdocumentfacilitytypeentity";
            KeySeparator = ".";
            Grouping = "/BankDocumentFacilityTypeEntity";

            AddGroup("BankDocumentFacilityTypeEntity Details", group =>
            {
                FacilityGroup = group.Add(new VocabularyKey(nameof(FacilityGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FacilityNature = group.Add(new VocabularyKey(nameof(FacilityNature), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FacilityGroupName = group.Add(new VocabularyKey(nameof(FacilityGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FacilityGroup { get; private set; }
        public VocabularyKey FacilityNature { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey FacilityGroupName { get; private set; }
    }
}