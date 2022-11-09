using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjInvoiceProposalEntityVocabulary : SimpleVocabulary
    {
        public ProjInvoiceProposalEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjInvoiceProposalEntity";
            KeyPrefix = "commonDataModel.projinvoiceproposalentity";
            KeySeparator = ".";
            Grouping = "/ProjInvoiceProposalEntity";

            AddGroup("Common Data Model ProjInvoiceProposalEntity Details", group =>
            {
                SalesCurrency = group.Add(new VocabularyKey(nameof(SalesCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FundingSource = group.Add(new VocabularyKey(nameof(FundingSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectContractId = group.Add(new VocabularyKey(nameof(ProjectContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceProposalId = group.Add(new VocabularyKey(nameof(InvoiceProposalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceHeaderText = group.Add(new VocabularyKey(nameof(InvoiceHeaderText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FundingSource_ContractId = group.Add(new VocabularyKey(nameof(FundingSource_ContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FundingSourceId = group.Add(new VocabularyKey(nameof(FundingSourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContractName = group.Add(new VocabularyKey(nameof(ContractName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceFormat = group.Add(new VocabularyKey(nameof(InvoiceFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryTransportBrand = group.Add(new VocabularyKey(nameof(DeliveryTransportBrand), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentTypeRecId = group.Add(new VocabularyKey(nameof(FiscalDocumentTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalEstablishmentRecId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BillOfLadingFreightChargeTerms = group.Add(new VocabularyKey(nameof(BillOfLadingFreightChargeTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ServiceFiscalInformationCode = group.Add(new VocabularyKey(nameof(ServiceFiscalInformationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryVehicleLicensePlateNumber = group.Add(new VocabularyKey(nameof(DeliveryVehicleLicensePlateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryVehicleLicensePlateState = group.Add(new VocabularyKey(nameof(DeliveryVehicleLicensePlateState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VolumeQuantity = group.Add(new VocabularyKey(nameof(VolumeQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VolumeType = group.Add(new VocabularyKey(nameof(VolumeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentTypeId = group.Add(new VocabularyKey(nameof(FiscalDocumentTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SalesCurrency { get; private set; }
public VocabularyKey FundingSource { get; private set; }
public VocabularyKey InvoiceDate { get; private set; }
public VocabularyKey Invoice { get; private set; }
public VocabularyKey ProjectContractId { get; private set; }
public VocabularyKey InvoiceProposalId { get; private set; }
public VocabularyKey InvoiceHeaderText { get; private set; }
public VocabularyKey FundingSource_ContractId { get; private set; }
public VocabularyKey FundingSourceId { get; private set; }
public VocabularyKey ContractName { get; private set; }
public VocabularyKey InvoiceFormat { get; private set; }
public VocabularyKey DeliveryTransportBrand { get; private set; }
public VocabularyKey FiscalDocumentTypeRecId { get; private set; }
public VocabularyKey FiscalEstablishmentRecId { get; private set; }
public VocabularyKey BillOfLadingFreightChargeTerms { get; private set; }
public VocabularyKey ServiceFiscalInformationCode { get; private set; }
public VocabularyKey DeliveryVehicleLicensePlateNumber { get; private set; }
public VocabularyKey DeliveryVehicleLicensePlateState { get; private set; }
public VocabularyKey VolumeQuantity { get; private set; }
public VocabularyKey VolumeType { get; private set; }
public VocabularyKey FiscalDocumentTypeId { get; private set; }
public VocabularyKey FiscalEstablishmentId { get; private set; }


    }
}