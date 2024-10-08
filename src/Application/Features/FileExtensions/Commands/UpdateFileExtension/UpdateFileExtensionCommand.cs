﻿using Application.Features.FileExtensions.Dtos;

namespace Application.Features.FileExtensions.Commands.UpdateFileExtension
{
    public class UpdateFileExtensionCommand : IRequest<FileExtensionDto>
    {
        public uint Id { get; set; }
        public string? Type { get; set; }
        public string? Icon { get; set; }
    }
}
