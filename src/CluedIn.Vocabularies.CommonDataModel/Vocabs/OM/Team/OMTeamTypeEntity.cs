using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OMTeamTypeEntityVocabulary : SimpleVocabulary
    {
        public OMTeamTypeEntityVocabulary()
        {
            VocabularyName = "OMTeamTypeEntity";
            KeyPrefix = "commonDataModel.omteamtypeentity";
            KeySeparator = ".";
            Grouping = "/OMTeamTypeEntity";

            AddGroup("OMTeamTypeEntity Details", group =>
            {
                AllowContact = group.Add(new VocabularyKey(nameof(AllowContact), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowContractor = group.Add(new VocabularyKey(nameof(AllowContractor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowCustomer = group.Add(new VocabularyKey(nameof(AllowCustomer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowEmployee = group.Add(new VocabularyKey(nameof(AllowEmployee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowVendor = group.Add(new VocabularyKey(nameof(AllowVendor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSystemCriterion = group.Add(new VocabularyKey(nameof(IsSystemCriterion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiresAXUser = group.Add(new VocabularyKey(nameof(RequiresAXUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AllowContact { get; private set; }
        public VocabularyKey AllowContractor { get; private set; }
        public VocabularyKey AllowCustomer { get; private set; }
        public VocabularyKey AllowEmployee { get; private set; }
        public VocabularyKey AllowVendor { get; private set; }
        public VocabularyKey IsSystemCriterion { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequiresAXUser { get; private set; }


    }
}