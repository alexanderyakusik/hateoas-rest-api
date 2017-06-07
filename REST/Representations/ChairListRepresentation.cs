using System.Collections.Generic;
using WebApi.Hal;

namespace REST.Representations
{
    public class ChairListRepresentation : SimpleListRepresentation<ChairRepresentation>
    {
        public ChairListRepresentation(IList<ChairRepresentation> chairs) : base(chairs)
        {

        }

        protected override void CreateHypermedia()
        {
            Links.Add(LinkTemplates.Chairs.AddChair);

            Href = LinkTemplates.Chairs.GetChairs.Href;

            Links.Add(new Link { Href = Href, Rel = "self" });
        }
    }
}