using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BranchEntityVocabulary : SimpleVocabulary
    {
        public BranchEntityVocabulary()
        {
            VocabularyName = "BranchEntity";
            KeyPrefix = "commonDataModel.branchentity";
            KeySeparator = ".";
            Grouping = "/BranchEntity";

            AddGroup("BranchEntity Details", group =>
            {
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlcoholRegulationAuthority = group.Add(new VocabularyKey(nameof(AlcoholRegulationAuthority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SeparateDivisionID = group.Add(new VocabularyKey(nameof(SeparateDivisionID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Independent = group.Add(new VocabularyKey(nameof(Independent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey VendorAccount { get; private set; }
        public VocabularyKey AlcoholRegulationAuthority { get; private set; }
        public VocabularyKey SeparateDivisionID { get; private set; }
        public VocabularyKey Independent { get; private set; }


    }
}