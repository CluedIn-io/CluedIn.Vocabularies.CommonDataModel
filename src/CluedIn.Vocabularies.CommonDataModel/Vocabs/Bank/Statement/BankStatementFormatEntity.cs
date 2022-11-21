using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankStatementFormatEntityVocabulary : SimpleVocabulary
    {
        public BankStatementFormatEntityVocabulary()
        {
            VocabularyName = "Bank Statement Format Entity";
            KeyPrefix = "commonDataModel.bankstatementformatentity";
            KeySeparator = ".";
            Grouping = "/BankStatementFormatEntity";

            AddGroup("BankStatementFormatEntity Details", group =>
            {
                FileType = group.Add(new VocabularyKey(nameof(FileType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromatId = group.Add(new VocabularyKey(nameof(FromatId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                XMLFile = group.Add(new VocabularyKey(nameof(XMLFile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DMFDefinitionGroupName = group.Add(new VocabularyKey(nameof(DMFDefinitionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseGERConfiguration = group.Add(new VocabularyKey(nameof(UseGERConfiguration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERModelMappingTable = group.Add(new VocabularyKey(nameof(ERModelMappingTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FileType { get; private set; }
        public VocabularyKey FromatId { get; private set; }
        public VocabularyKey XMLFile { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey DMFDefinitionGroupName { get; private set; }
        public VocabularyKey UseGERConfiguration { get; private set; }
        public VocabularyKey ERModelMappingTable { get; private set; }
    }
}