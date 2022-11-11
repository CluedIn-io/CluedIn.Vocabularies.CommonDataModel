using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorPaymentMethodSpecificationEntityVocabulary : SimpleVocabulary
    {
        public VendorPaymentMethodSpecificationEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendorPaymentMethodSpecificationEntity";
            KeyPrefix = "commonDataModel.vendorpaymentmethodspecificationentity";
            KeySeparator = ".";
            Grouping = "/VendorPaymentMethodSpecificationEntity";

            AddGroup("Common Data Model VendorPaymentMethodSpecificationEntity Details", group =>
            {
                ClassId = group.Add(new VocabularyKey(nameof(ClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentMethodName = group.Add(new VocabularyKey(nameof(PaymentMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassName = group.Add(new VocabularyKey(nameof(ClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecParameters = group.Add(new VocabularyKey(nameof(SpecParameters), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicPaymentType = group.Add(new VocabularyKey(nameof(ElectronicPaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicPaymentWay = group.Add(new VocabularyKey(nameof(ElectronicPaymentWay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicPaymentSegment = group.Add(new VocabularyKey(nameof(ElectronicPaymentSegment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicPaymentValidationControl = group.Add(new VocabularyKey(nameof(ElectronicPaymentValidationControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ClassId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PaymentMethodName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ClassName { get; private set; }
        public VocabularyKey SpecParameters { get; private set; }
        public VocabularyKey ElectronicPaymentType { get; private set; }
        public VocabularyKey ElectronicPaymentWay { get; private set; }
        public VocabularyKey ElectronicPaymentSegment { get; private set; }
        public VocabularyKey ElectronicPaymentValidationControl { get; private set; }


    }
}