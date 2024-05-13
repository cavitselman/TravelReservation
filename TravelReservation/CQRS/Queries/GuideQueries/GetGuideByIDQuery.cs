using MediatR;
using TravelReservation.CQRS.Results.GuideResults;

namespace TravelReservation.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery:IRequest<GetGuideByIDQueryResult>
    {
        public GetGuideByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
