using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProdComParametersEntityVocabulary : SimpleVocabulary
    {
        public ProdComParametersEntityVocabulary()
        {
            VocabularyName = "ProdComParametersEntity";
            KeyPrefix = "commonDataModel.prodcomparametersentity";
            KeySeparator = ".";
            Grouping = "/ProdComParametersEntity";

            AddGroup("ProdComParametersEntity Details", group =>
            {
                AutomaticRecalculation = group.Add(new VocabularyKey(nameof(AutomaticRecalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BranchNumber = group.Add(new VocabularyKey(nameof(BranchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactID = group.Add(new VocabularyKey(nameof(PrimaryContactID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalContactID = group.Add(new VocabularyKey(nameof(ExternalContactID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AutomaticRecalculation { get; private set; }
        public VocabularyKey BranchNumber { get; private set; }
        public VocabularyKey PrimaryContactID { get; private set; }
        public VocabularyKey ExternalContactID { get; private set; }
        public VocabularyKey ID { get; private set; }
        public VocabularyKey Company { get; private set; }


    }
}