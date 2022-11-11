using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdingTaxRegistrationNumberEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdingTaxRegistrationNumberEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxWithholdingTaxRegistrationNumberEntity";
            KeyPrefix = "commonDataModel.taxwithholdingtaxregistrationnumberentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdingTaxRegistrationNumberEntity";

            AddGroup("Common Data Model TaxWithholdingTaxRegistrationNumberEntity Details", group =>
            {
                Shared = group.Add(new VocabularyKey(nameof(Shared), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefCompanyId = group.Add(new VocabularyKey(nameof(RefCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNumber = group.Add(new VocabularyKey(nameof(RegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNumberType = group.Add(new VocabularyKey(nameof(RegistrationNumberType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TANRegistrationNumber = group.Add(new VocabularyKey(nameof(TANRegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TCSAssessingofficer = group.Add(new VocabularyKey(nameof(TCSAssessingofficer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TCSCircleNumber = group.Add(new VocabularyKey(nameof(TCSCircleNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TCSWardNumber = group.Add(new VocabularyKey(nameof(TCSWardNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TDSAssessingofficer = group.Add(new VocabularyKey(nameof(TDSAssessingofficer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TDSCircleNumber = group.Add(new VocabularyKey(nameof(TDSCircleNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TDSWardNumber = group.Add(new VocabularyKey(nameof(TDSWardNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Shared { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey RefCompanyId { get; private set; }
        public VocabularyKey RegistrationNumber { get; private set; }
        public VocabularyKey RegistrationNumberType { get; private set; }
        public VocabularyKey TANRegistrationNumber { get; private set; }
        public VocabularyKey TCSAssessingofficer { get; private set; }
        public VocabularyKey TCSCircleNumber { get; private set; }
        public VocabularyKey TCSWardNumber { get; private set; }
        public VocabularyKey TDSAssessingofficer { get; private set; }
        public VocabularyKey TDSCircleNumber { get; private set; }
        public VocabularyKey TDSWardNumber { get; private set; }


    }
}