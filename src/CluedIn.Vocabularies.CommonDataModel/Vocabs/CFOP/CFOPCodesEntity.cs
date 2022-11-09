using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CFOPCodesEntityVocabulary : SimpleVocabulary
    {
        public CFOPCodesEntityVocabulary()
        {
            VocabularyName = "Common Data Model CFOPCodesEntity";
            KeyPrefix = "commonDataModel.cfopcodesentity";
            KeySeparator = ".";
            Grouping = "/CFOPCodesEntity";

            AddGroup("Common Data Model CFOPCodesEntity Details", group =>
            {
                CFOP = group.Add(new VocabularyKey(nameof(CFOP), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SearchName = group.Add(new VocabularyKey(nameof(SearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentTextId = group.Add(new VocabularyKey(nameof(FiscalDocumentTextId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentText = group.Add(new VocabularyKey(nameof(FiscalDocumentText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Direction = group.Add(new VocabularyKey(nameof(Direction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryCFOPId = group.Add(new VocabularyKey(nameof(DeliveryCFOPId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryCFOP = group.Add(new VocabularyKey(nameof(DeliveryCFOP), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConsiderInCIAP = group.Add(new VocabularyKey(nameof(ConsiderInCIAP), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalReferenceRequired = group.Add(new VocabularyKey(nameof(FiscalReferenceRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentSourceTextId = group.Add(new VocabularyKey(nameof(FiscalDocumentSourceTextId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentSourceText = group.Add(new VocabularyKey(nameof(FiscalDocumentSourceText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalReferenceLegalText = group.Add(new VocabularyKey(nameof(FiscalReferenceLegalText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CFOP { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey SearchName { get; private set; }
public VocabularyKey Location { get; private set; }
public VocabularyKey FiscalDocumentTextId { get; private set; }
public VocabularyKey FiscalDocumentText { get; private set; }
public VocabularyKey Direction { get; private set; }
public VocabularyKey Purpose { get; private set; }
public VocabularyKey DeliveryCFOPId { get; private set; }
public VocabularyKey DeliveryCFOP { get; private set; }
public VocabularyKey ConsiderInCIAP { get; private set; }
public VocabularyKey FiscalReferenceRequired { get; private set; }
public VocabularyKey FiscalDocumentSourceTextId { get; private set; }
public VocabularyKey FiscalDocumentSourceText { get; private set; }
public VocabularyKey FiscalReferenceLegalText { get; private set; }


    }
}