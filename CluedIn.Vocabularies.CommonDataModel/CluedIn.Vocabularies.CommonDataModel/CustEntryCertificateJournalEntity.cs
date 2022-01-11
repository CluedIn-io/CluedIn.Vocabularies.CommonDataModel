using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustEntryCertificateJournalEntityVocabulary : SimpleVocabulary
    {
        public CustEntryCertificateJournalEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustEntryCertificateJournalEntity";
            KeyPrefix = "commonDataModel.custentrycertificatejournalentity";
            KeySeparator = ".";
            Grouping = "/CustEntryCertificateJournalEntity";

            AddGroup("Common Data Model CustEntryCertificateJournalEntity Details", group =>
            {
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EntryCertificate = group.Add(new VocabularyKey(nameof(EntryCertificate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsThirdParty = group.Add(new VocabularyKey(nameof(IsThirdParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PackingSlip = group.Add(new VocabularyKey(nameof(PackingSlip), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesOrder = group.Add(new VocabularyKey(nameof(SalesOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceRecId = group.Add(new VocabularyKey(nameof(SourceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceTableId = group.Add(new VocabularyKey(nameof(SourceTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryPostalAddress = group.Add(new VocabularyKey(nameof(DeliveryPostalAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddress = group.Add(new VocabularyKey(nameof(DeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryCity = group.Add(new VocabularyKey(nameof(DeliveryCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryCountry = group.Add(new VocabularyKey(nameof(DeliveryCountry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryCountryISOCode = group.Add(new VocabularyKey(nameof(DeliveryCountryISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryCounty = group.Add(new VocabularyKey(nameof(DeliveryCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryDistrictName = group.Add(new VocabularyKey(nameof(DeliveryDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryLatitude = group.Add(new VocabularyKey(nameof(DeliveryLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryLocationId = group.Add(new VocabularyKey(nameof(DeliveryLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryLongitude = group.Add(new VocabularyKey(nameof(DeliveryLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryPostBox = group.Add(new VocabularyKey(nameof(DeliveryPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryState = group.Add(new VocabularyKey(nameof(DeliveryState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryStreet = group.Add(new VocabularyKey(nameof(DeliveryStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryTimeZone = group.Add(new VocabularyKey(nameof(DeliveryTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryValidFrom = group.Add(new VocabularyKey(nameof(DeliveryValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryValidTo = group.Add(new VocabularyKey(nameof(DeliveryValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryZipCode = group.Add(new VocabularyKey(nameof(DeliveryZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryDescription = group.Add(new VocabularyKey(nameof(DeliveryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesUnit = group.Add(new VocabularyKey(nameof(SalesUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LotId = group.Add(new VocabularyKey(nameof(LotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentInvoiceId = group.Add(new VocabularyKey(nameof(DocumentInvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentInvoiceDate = group.Add(new VocabularyKey(nameof(DocumentInvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentInvoiceRecId = group.Add(new VocabularyKey(nameof(DocumentInvoiceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CustomerAccount { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey EntryCertificate { get; private set; }
public VocabularyKey Invoice { get; private set; }
public VocabularyKey IsThirdParty { get; private set; }
public VocabularyKey Language { get; private set; }
public VocabularyKey PackingSlip { get; private set; }
public VocabularyKey SalesOrder { get; private set; }
public VocabularyKey SourceRecId { get; private set; }
public VocabularyKey SourceTableId { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey Company { get; private set; }
public VocabularyKey DeliveryPostalAddress { get; private set; }
public VocabularyKey DeliveryAddress { get; private set; }
public VocabularyKey DeliveryBuildingCompliment { get; private set; }
public VocabularyKey DeliveryCity { get; private set; }
public VocabularyKey DeliveryCountry { get; private set; }
public VocabularyKey DeliveryCountryISOCode { get; private set; }
public VocabularyKey DeliveryCounty { get; private set; }
public VocabularyKey DeliveryDistrictName { get; private set; }
public VocabularyKey DeliveryLatitude { get; private set; }
public VocabularyKey DeliveryLocationId { get; private set; }
public VocabularyKey DeliveryLongitude { get; private set; }
public VocabularyKey DeliveryPostBox { get; private set; }
public VocabularyKey DeliveryState { get; private set; }
public VocabularyKey DeliveryStreet { get; private set; }
public VocabularyKey DeliveryStreetNumber { get; private set; }
public VocabularyKey DeliveryTimeZone { get; private set; }
public VocabularyKey DeliveryValidFrom { get; private set; }
public VocabularyKey DeliveryValidTo { get; private set; }
public VocabularyKey DeliveryZipCode { get; private set; }
public VocabularyKey DeliveryDescription { get; private set; }
public VocabularyKey ItemId { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey SalesUnit { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey LotId { get; private set; }
public VocabularyKey DocumentInvoiceId { get; private set; }
public VocabularyKey DocumentInvoiceDate { get; private set; }
public VocabularyKey DocumentInvoiceRecId { get; private set; }


    }
}