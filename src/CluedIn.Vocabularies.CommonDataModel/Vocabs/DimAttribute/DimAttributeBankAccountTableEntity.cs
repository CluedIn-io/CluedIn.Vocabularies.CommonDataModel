using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeBankAccountTableEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeBankAccountTableEntityVocabulary()
        {
            VocabularyName = "Dim Attribute Bank Account Table Entity";
            KeyPrefix = "commonDataModel.dimattributebankaccounttableentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeBankAccountTableEntity";

            AddGroup("DimAttributeBankAccountTableEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}