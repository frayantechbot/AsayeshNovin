﻿using Core.Application.Services;
using Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Core.Presentation.Controllers;

/// <summary>
/// Basic CRUD Controller
/// </summary>
[ApiController]
[Route("[controller]")]
[Consumes("application/json")]
[Produces("application/json")]
public class BaseController<TEntity, TCreateDto, TUpdateDto, TResponseDto>
    : ControllerBase, IBaseController<TCreateDto, TUpdateDto>
    where TEntity : BaseEntity
    where TCreateDto : class
    where TUpdateDto : class
{
    private readonly IBaseService<TEntity, TCreateDto, TUpdateDto> _service;
    private readonly Func<TEntity?, TResponseDto> _mapper;

    public BaseController(
        IBaseService<TEntity, TCreateDto, TUpdateDto> service,
        Func<TEntity?, TResponseDto> mapper
    )
    {
        _service = service;
        _mapper = mapper;
    }

    /// <summary>
    /// Get all items
    /// </summary>
    [HttpGet]
    public virtual async Task<IActionResult> GetAllAsync()
    {
        return Ok((await _service.GetAllAsync()).Select(t => _mapper(t)));
    }

    /// <summary>
    /// Get by id
    /// </summary>
    /// <param name="id">Item's id</param>
    [HttpGet("{id:guid}")]
    public virtual async Task<IActionResult> GetByIdAsync(Guid id)
    {
        return Ok(_mapper(await _service.FindByIdAsync(id)));
    }

    /// <summary>
    /// Create new item
    /// </summary>
    /// <param name="createDto"></param>
    [HttpPost]
    public virtual async Task<IActionResult> CreateAsync([FromBody] TCreateDto createDto)
    {
        return Ok(_mapper(await _service.CreateAsync(createDto)));
    }

    /// <summary>
    /// Update item 
    /// </summary>
    /// <param name="id">Item's id</param>
    /// <param name="updateDto"></param>
    [HttpPut("{id:guid}")]
    public virtual async Task<IActionResult> UpdateAsync(Guid id, [FromBody] TUpdateDto updateDto)
    {
        return Ok(_mapper(await _service.UpdateAsync(id, updateDto)));
    }

    /// <summary>
    /// Soft delete item
    /// </summary>
    /// <param name="id">Item's id</param>
    [HttpPost("delete/{id:guid}")]
    public virtual async Task<IActionResult> Delete(Guid id)
    {
        return Ok(await _service.DeleteAsync(id));
    }

    /// <summary>
    /// Restore soft deleted item
    /// </summary>
    /// <param name="id">Item's id</param>
    [HttpPost("restore/{id:guid}")]
    public virtual async Task<IActionResult> Restore(Guid id)
    {
        return Ok(await _service.RestoreAsync(id));
    }

    /// <summary>
    /// Force delete item
    /// </summary>
    /// <param name="id">Item's id</param>
    [HttpDelete("{id:guid}")]
    public virtual async Task<IActionResult> ForceDeleteAsync(Guid id)
    {
        return Ok(await _service.ForceDeleteAsync(id));
    }
}