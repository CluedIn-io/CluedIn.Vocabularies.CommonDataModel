using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectGrantCustomerTypeEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectGrantCustomerTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjProjectGrantCustomerTypeEntity";
            KeyPrefix = "commonDataModel.projprojectgrantcustomertypeentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectGrantCustomerTypeEntity";

            AddGroup("Common Data Model ProjProjectGrantCustomerTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrantorType = group.Add(new VocabularyKey(nameof(GrantorType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey GrantorType { get; private set; }


    }
}