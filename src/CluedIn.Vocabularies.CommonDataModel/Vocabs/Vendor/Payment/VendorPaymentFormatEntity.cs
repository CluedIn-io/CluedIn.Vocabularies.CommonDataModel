using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorPaymentFormatEntityVocabulary : SimpleVocabulary
    {
        public VendorPaymentFormatEntityVocabulary()
        {
            VocabularyName = "VendorPaymentFormatEntity";
            KeyPrefix = "commonDataModel.vendorpaymentformatentity";
            KeySeparator = ".";
            Grouping = "/VendorPaymentFormatEntity";

            AddGroup("VendorPaymentFormatEntity Details", group =>
            {
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassId = group.Add(new VocabularyKey(nameof(ClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassName = group.Add(new VocabularyKey(nameof(ClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Type { get; private set; }
        public VocabularyKey ClassId { get; private set; }
        public VocabularyKey ClassName { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}