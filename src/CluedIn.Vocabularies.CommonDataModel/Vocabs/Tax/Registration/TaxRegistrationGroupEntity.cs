using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxRegistrationGroupEntityVocabulary : SimpleVocabulary
    {
        public TaxRegistrationGroupEntityVocabulary()
        {
            VocabularyName = "Tax Registration Group Entity";
            KeyPrefix = "commonDataModel.taxregistrationgroupentity";
            KeySeparator = ".";
            Grouping = "/TaxRegistrationGroupEntity";

            AddGroup("TaxRegistrationGroupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InUse = group.Add(new VocabularyKey(nameof(InUse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegistrationGroup = group.Add(new VocabularyKey(nameof(TaxRegistrationGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegistrationNumberTable = group.Add(new VocabularyKey(nameof(TaxRegistrationNumberTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegistrationNumber = group.Add(new VocabularyKey(nameof(TaxRegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistratonNumberDescription = group.Add(new VocabularyKey(nameof(RegistratonNumberDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey InUse { get; private set; }
        public VocabularyKey TaxRegistrationGroup { get; private set; }
        public VocabularyKey TaxRegistrationNumberTable { get; private set; }
        public VocabularyKey TaxType { get; private set; }
        public VocabularyKey TaxRegistrationNumber { get; private set; }
        public VocabularyKey RegistratonNumberDescription { get; private set; }
    }
}