using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PdsBatchDispositionEntityVocabulary : SimpleVocabulary
    {
        public PdsBatchDispositionEntityVocabulary()
        {
            VocabularyName = "Common Data Model PdsBatchDispositionEntity";
            KeyPrefix = "commonDataModel.pdsbatchdispositionentity";
            KeySeparator = ".";
            Grouping = "/PdsBatchDispositionEntity";

            AddGroup("Common Data Model PdsBatchDispositionEntity Details", group =>
            {
                DispositionCode = group.Add(new VocabularyKey(nameof(DispositionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DispositionDescription = group.Add(new VocabularyKey(nameof(DispositionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DispositionStatus = group.Add(new VocabularyKey(nameof(DispositionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillNetRequirementCalculationIncludeBatches = group.Add(new VocabularyKey(nameof(WillNetRequirementCalculationIncludeBatches), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillBlockProductionPicking = group.Add(new VocabularyKey(nameof(WillBlockProductionPicking), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillBlockProductionPickingJournal = group.Add(new VocabularyKey(nameof(WillBlockProductionPickingJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillBlockProductionReservation = group.Add(new VocabularyKey(nameof(WillBlockProductionReservation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillBlockSalesPicking = group.Add(new VocabularyKey(nameof(WillBlockSalesPicking), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillBlockSalesReservation = group.Add(new VocabularyKey(nameof(WillBlockSalesReservation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillBlockSalesShipping = group.Add(new VocabularyKey(nameof(WillBlockSalesShipping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillBlockTransferPicking = group.Add(new VocabularyKey(nameof(WillBlockTransferPicking), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillBlockTransferReservation = group.Add(new VocabularyKey(nameof(WillBlockTransferReservation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillBlockTransferShipping = group.Add(new VocabularyKey(nameof(WillBlockTransferShipping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DispositionCode { get; private set; }
public VocabularyKey DispositionDescription { get; private set; }
public VocabularyKey DispositionStatus { get; private set; }
public VocabularyKey WillNetRequirementCalculationIncludeBatches { get; private set; }
public VocabularyKey WillBlockProductionPicking { get; private set; }
public VocabularyKey WillBlockProductionPickingJournal { get; private set; }
public VocabularyKey WillBlockProductionReservation { get; private set; }
public VocabularyKey WillBlockSalesPicking { get; private set; }
public VocabularyKey WillBlockSalesReservation { get; private set; }
public VocabularyKey WillBlockSalesShipping { get; private set; }
public VocabularyKey WillBlockTransferPicking { get; private set; }
public VocabularyKey WillBlockTransferReservation { get; private set; }
public VocabularyKey WillBlockTransferShipping { get; private set; }


    }
}