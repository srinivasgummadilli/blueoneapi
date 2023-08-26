using Ardalis.ApiEndpoints;
using BlueAPI;
using BlueAPI.IService;
using BlueAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Mirra.API.CredAxis3.WebApp;

[Route(Routes.Masters)]
public sealed class DEASchedules : EndpointBaseAsync.WithoutRequest.WithActionResult<DEASchedulesModel>
{
    private readonly ILogger _logger;
    private readonly IMasterService _iMasterService;

    public DEASchedules(ILogger<DEASchedules> logger, IMasterService iMasterService)
    {
        _logger = logger;
        _iMasterService = iMasterService;
    }


    [HttpGet(Routes.DEASchedules)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Produces(CredAxisConstant.APPLICATIONORJSON)]
    [SwaggerOperation(Tags = new[] { "Masters" })]
    public override async Task<ActionResult<DEASchedulesModel>> HandleAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            return Ok(await _iMasterService.GetDEASchedules());
        }
        catch (Exception ex)
        {
            _logger.LogError("Error while fetching DEA Schedules : " + ex);
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}


