using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerRRGTransType_RUEntityVocabulary : SimpleVocabulary
    {
        public LedgerRRGTransType_RUEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerRRGTransType_RUEntity";
            KeyPrefix = "commonDataModel.ledgerrrgtranstype_ruentity";
            KeySeparator = ".";
            Grouping = "/LedgerRRGTransType_RUEntity";

            AddGroup("Common Data Model LedgerRRGTransType_RUEntity Details", group =>
            {
                TransType = group.Add(new VocabularyKey(nameof(TransType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RefTableName = group.Add(new VocabularyKey(nameof(RefTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RefLineId = group.Add(new VocabularyKey(nameof(RefLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransTypeRecId = group.Add(new VocabularyKey(nameof(TransTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransTypeTableId = group.Add(new VocabularyKey(nameof(TransTypeTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TransType { get; private set; }
public VocabularyKey RefTableName { get; private set; }
public VocabularyKey RefLineId { get; private set; }
public VocabularyKey TransTypeRecId { get; private set; }
public VocabularyKey TransTypeTableId { get; private set; }


    }
}