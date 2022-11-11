using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BLWIParameterEntityVocabulary : SimpleVocabulary
    {
        public BLWIParameterEntityVocabulary()
        {
            VocabularyName = "BLWIParameterEntity";
            KeyPrefix = "commonDataModel.blwiparameterentity";
            KeySeparator = ".";
            Grouping = "/BLWIParameterEntity";

            AddGroup("BLWIParameterEntity Details", group =>
            {
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BLWI = group.Add(new VocabularyKey(nameof(BLWI), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeclarationPeriod = group.Add(new VocabularyKey(nameof(DeclarationPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CentralBankPurposeCode = group.Add(new VocabularyKey(nameof(CentralBankPurposeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckBLWICodeOnJournals = group.Add(new VocabularyKey(nameof(CheckBLWICodeOnJournals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransformResponse = group.Add(new VocabularyKey(nameof(TransformResponse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Fax = group.Add(new VocabularyKey(nameof(Fax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Phone = group.Add(new VocabularyKey(nameof(Phone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NBBMail = group.Add(new VocabularyKey(nameof(NBBMail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ID { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey BLWI { get; private set; }
        public VocabularyKey DeclarationPeriod { get; private set; }
        public VocabularyKey CentralBankPurposeCode { get; private set; }
        public VocabularyKey CheckBLWICodeOnJournals { get; private set; }
        public VocabularyKey TransformResponse { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey NBBMail { get; private set; }


    }
}