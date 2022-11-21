using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ResResourceDataEntityVocabulary : SimpleVocabulary
    {
        public ResResourceDataEntityVocabulary()
        {
            VocabularyName = "Res Resource Data Entity";
            KeyPrefix = "commonDataModel.resresourcedataentity";
            KeySeparator = ".";
            Grouping = "/ResResourceDataEntity";

            AddGroup("ResResourceDataEntity Details", group =>
            {
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendId = group.Add(new VocabularyKey(nameof(VendId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecordId = group.Add(new VocabularyKey(nameof(RecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCompanyId = group.Add(new VocabularyKey(nameof(ResourceCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey VendId { get; private set; }
        public VocabularyKey RecordId { get; private set; }
        public VocabularyKey ResourceCompanyId { get; private set; }
    }
}