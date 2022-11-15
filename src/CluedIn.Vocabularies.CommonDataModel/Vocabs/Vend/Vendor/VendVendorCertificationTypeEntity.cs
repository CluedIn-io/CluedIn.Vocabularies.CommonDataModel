using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendVendorCertificationTypeEntityVocabulary : SimpleVocabulary
    {
        public VendVendorCertificationTypeEntityVocabulary()
        {
            VocabularyName = "Vend Vendor Certification Type Entity";
            KeyPrefix = "commonDataModel.vendvendorcertificationtypeentity";
            KeySeparator = ".";
            Grouping = "/VendVendorCertificationTypeEntity";

            AddGroup("VendVendorCertificationTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}