using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmPositionUnionAgreementEntityVocabulary : SimpleVocabulary
    {
        public HcmPositionUnionAgreementEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmPositionUnionAgreementEntity";
            KeyPrefix = "commonDataModel.hcmpositionunionagreemententity";
            KeySeparator = ".";
            Grouping = "/HcmPositionUnionAgreementEntity";

            AddGroup("Common Data Model HcmPositionUnionAgreementEntity Details", group =>
            {
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnionAgreement = group.Add(new VocabularyKey(nameof(UnionAgreement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnionAgreementName = group.Add(new VocabularyKey(nameof(UnionAgreementName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LaborUnion = group.Add(new VocabularyKey(nameof(LaborUnion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LaborUnionId = group.Add(new VocabularyKey(nameof(LaborUnionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Position { get; private set; }
public VocabularyKey UnionAgreement { get; private set; }
public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }
public VocabularyKey PositionId { get; private set; }
public VocabularyKey UnionAgreementName { get; private set; }
public VocabularyKey LaborUnion { get; private set; }
public VocabularyKey LegalEntity { get; private set; }
public VocabularyKey LaborUnionId { get; private set; }
public VocabularyKey LegalEntityId { get; private set; }


    }
}