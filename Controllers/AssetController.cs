using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Back_end.DB.DTO;
using Back_end.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Back_end.Controllers
{
    [Route("[controller]")]
    public class AssetController : ControllerBase
    {
        private IAssetService _service;
        public AssetController(IAssetService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task AddAsset([FromBody] AssetDTO asset)
        {
            await _service.AddAsset(asset);
        }
        [HttpPut("{id}")]
        public async Task UpdateAsset(int id, [FromBody] AssetDTO asset)
        {
            await _service.UpdateAsset(asset, id);
        }
        [HttpDelete("{id}")]
        public async Task DeleteAsset(int id)
        {
            await _service.DeleteAsset(id);
        }
        [HttpGet("{id}")]
        public async Task<AssetDTO> GetAsset(int id)
        {
            return await _service.GetAsset(id);
        }
        [HttpGet("all")]
        public async Task<List<AssetDTO>> GetAllAsset()
        {
            return await _service.GetAllAsset();
        }
    }
}