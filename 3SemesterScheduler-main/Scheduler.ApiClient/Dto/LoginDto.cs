﻿using System.ComponentModel.DataAnnotations;

namespace Scheduler.ApiClient.Dto;

public class LoginDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 8)]
    [DataType(DataType.Password)]
    public string Password { get; set; } = default!;
}
