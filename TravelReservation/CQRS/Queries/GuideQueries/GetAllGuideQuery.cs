using MediatR;
using TravelReservation.CQRS.Results.GuideResults;

namespace TravelReservation.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
