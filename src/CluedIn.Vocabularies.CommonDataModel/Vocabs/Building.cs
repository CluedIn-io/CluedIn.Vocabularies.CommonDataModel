using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BuildingVocabulary : SimpleVocabulary
    {
        public BuildingVocabulary()
        {
            VocabularyName = "Common Data Model Building";
            KeyPrefix = "commonDataModel.building";
            KeySeparator = ".";
            Grouping = "/Building";

            AddGroup("Common Data Model Building Details", group =>
            {
                exchangeRate = group.Add(new VocabularyKey(nameof(exchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
accessibleToilets = group.Add(new VocabularyKey(nameof(accessibleToilets), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
additionalFacilities = group.Add(new VocabularyKey(nameof(additionalFacilities), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
addressComposite = group.Add(new VocabularyKey(nameof(addressComposite), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
addressLine1 = group.Add(new VocabularyKey(nameof(addressLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
addressLine2 = group.Add(new VocabularyKey(nameof(addressLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
addressLine3 = group.Add(new VocabularyKey(nameof(addressLine3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
buildingId = group.Add(new VocabularyKey(nameof(buildingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
city = group.Add(new VocabularyKey(nameof(city), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
cost = group.Add(new VocabularyKey(nameof(cost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
costBase = group.Add(new VocabularyKey(nameof(costBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
country = group.Add(new VocabularyKey(nameof(country), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
disabledAccess = group.Add(new VocabularyKey(nameof(disabledAccess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
disabledParking = group.Add(new VocabularyKey(nameof(disabledParking), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
email = group.Add(new VocabularyKey(nameof(email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
estimatedCapacity = group.Add(new VocabularyKey(nameof(estimatedCapacity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
numberOfRooms = group.Add(new VocabularyKey(nameof(numberOfRooms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
postalCode = group.Add(new VocabularyKey(nameof(postalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
publicTelephoneAvailable = group.Add(new VocabularyKey(nameof(publicTelephoneAvailable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateProvince = group.Add(new VocabularyKey(nameof(stateProvince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
telephone1 = group.Add(new VocabularyKey(nameof(telephone1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
telephone2 = group.Add(new VocabularyKey(nameof(telephone2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
telephone3 = group.Add(new VocabularyKey(nameof(telephone3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
website = group.Add(new VocabularyKey(nameof(website), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
wiFiAvailable = group.Add(new VocabularyKey(nameof(wiFiAvailable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
wiFiPassword = group.Add(new VocabularyKey(nameof(wiFiPassword), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
wiFiSSID = group.Add(new VocabularyKey(nameof(wiFiSSID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey exchangeRate { get; private set; }
public VocabularyKey accessibleToilets { get; private set; }
public VocabularyKey additionalFacilities { get; private set; }
public VocabularyKey addressComposite { get; private set; }
public VocabularyKey addressLine1 { get; private set; }
public VocabularyKey addressLine2 { get; private set; }
public VocabularyKey addressLine3 { get; private set; }
public VocabularyKey buildingId { get; private set; }
public VocabularyKey city { get; private set; }
public VocabularyKey cost { get; private set; }
public VocabularyKey costBase { get; private set; }
public VocabularyKey country { get; private set; }
public VocabularyKey description { get; private set; }
public VocabularyKey disabledAccess { get; private set; }
public VocabularyKey disabledParking { get; private set; }
public VocabularyKey email { get; private set; }
public VocabularyKey estimatedCapacity { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey numberOfRooms { get; private set; }
public VocabularyKey postalCode { get; private set; }
public VocabularyKey publicTelephoneAvailable { get; private set; }
public VocabularyKey stateProvince { get; private set; }
public VocabularyKey telephone1 { get; private set; }
public VocabularyKey telephone2 { get; private set; }
public VocabularyKey telephone3 { get; private set; }
public VocabularyKey website { get; private set; }
public VocabularyKey wiFiAvailable { get; private set; }
public VocabularyKey wiFiPassword { get; private set; }
public VocabularyKey wiFiSSID { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}