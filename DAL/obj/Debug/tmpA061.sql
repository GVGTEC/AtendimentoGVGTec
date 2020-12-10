alter table `Solicitante` drop column `AtivoInativo`
alter table `Atendente` drop column `AtivoInativo`
DELETE FROM `__MigrationHistory` WHERE `MigrationId` = '202002060110106_ATUALIZA5';
