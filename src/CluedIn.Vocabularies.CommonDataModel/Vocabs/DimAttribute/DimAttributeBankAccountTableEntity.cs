using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeBankAccountTableEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeBankAccountTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeBankAccountTableEntity";
            KeyPrefix = "commonDataModel.dimattributebankaccounttableentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeBankAccountTableEntity";

            AddGroup("Common Data Model DimAttributeBankAccountTableEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Value { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}