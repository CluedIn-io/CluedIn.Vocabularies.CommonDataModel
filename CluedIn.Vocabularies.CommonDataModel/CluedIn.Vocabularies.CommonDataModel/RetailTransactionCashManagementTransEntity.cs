using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionCashManagementTransEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionCashManagementTransEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTransactionCashManagementTransEntity";
            KeyPrefix = "commonDataModel.retailtransactioncashmanagementtransentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionCashManagementTransEntity";

            AddGroup("Common Data Model RetailTransactionCashManagementTransEntity Details", group =>
            {
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromSafe = group.Add(new VocabularyKey(nameof(FromSafe), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToSafe = group.Add(new VocabularyKey(nameof(ToSafe), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromShiftTerminalId = group.Add(new VocabularyKey(nameof(FromShiftTerminalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToShiftTerminalId = group.Add(new VocabularyKey(nameof(ToShiftTerminalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromShiftId = group.Add(new VocabularyKey(nameof(FromShiftId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToShiftId = group.Add(new VocabularyKey(nameof(ToShiftId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailChannelTableOMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTableOMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Channel { get; private set; }
public VocabularyKey Terminal { get; private set; }
public VocabularyKey TransactionNumber { get; private set; }
public VocabularyKey FromSafe { get; private set; }
public VocabularyKey ToSafe { get; private set; }
public VocabularyKey FromShiftTerminalId { get; private set; }
public VocabularyKey ToShiftTerminalId { get; private set; }
public VocabularyKey FromShiftId { get; private set; }
public VocabularyKey ToShiftId { get; private set; }
public VocabularyKey OperatingUnitNumber { get; private set; }
public VocabularyKey RetailChannelTableOMOperatingUnitID { get; private set; }


    }
}