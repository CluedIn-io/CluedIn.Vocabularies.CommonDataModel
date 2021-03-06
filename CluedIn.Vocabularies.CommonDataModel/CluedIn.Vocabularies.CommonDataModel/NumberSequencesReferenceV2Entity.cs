using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class NumberSequencesReferenceV2EntityVocabulary : SimpleVocabulary
    {
        public NumberSequencesReferenceV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model NumberSequencesReferenceV2Entity";
            KeyPrefix = "commonDataModel.numbersequencesreferencev2entity";
            KeySeparator = ".";
            Grouping = "/NumberSequencesReferenceV2Entity";

            AddGroup("Common Data Model NumberSequencesReferenceV2Entity Details", group =>
            {
                ReuseNumbers = group.Add(new VocabularyKey(nameof(ReuseNumbers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceDatatype = group.Add(new VocabularyKey(nameof(NumberSequenceDatatype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceCodeRecId = group.Add(new VocabularyKey(nameof(NumberSequenceCodeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceScope = group.Add(new VocabularyKey(nameof(NumberSequenceScope), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceCode = group.Add(new VocabularyKey(nameof(NumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DataTypeName = group.Add(new VocabularyKey(nameof(DataTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ScopeValue = group.Add(new VocabularyKey(nameof(ScopeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ScopeType = group.Add(new VocabularyKey(nameof(ScopeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ReuseNumbers { get; private set; }
public VocabularyKey NumberSequenceDatatype { get; private set; }
public VocabularyKey NumberSequenceCodeRecId { get; private set; }
public VocabularyKey NumberSequenceScope { get; private set; }
public VocabularyKey NumberSequenceCode { get; private set; }
public VocabularyKey DataTypeName { get; private set; }
public VocabularyKey ScopeValue { get; private set; }
public VocabularyKey ScopeType { get; private set; }


    }
}