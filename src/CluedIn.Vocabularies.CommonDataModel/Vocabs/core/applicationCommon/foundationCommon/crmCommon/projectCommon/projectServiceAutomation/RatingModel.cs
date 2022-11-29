using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class RatingModelVocabulary : SimpleVocabulary
    {
        public RatingModelVocabulary()
        {
            VocabularyName = "Rating Model";
            KeyPrefix = "commonDataModel.ratingmodel.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/RatingModel";

            AddGroup("RatingModel Details for ProjectServiceAutomation", group =>
            {
			    RatableEntity = group.Add(new VocabularyKey(nameof(RatableEntity), "Ratable Entity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RatableEntity { get; private set; }
    }
}