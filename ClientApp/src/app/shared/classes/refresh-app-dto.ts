export class RefreshAppDTO {
    constructor(
        public application_name?: string,
        public environment_name?: string
      ) {
        this.application_name = "";
        this.environment_name = "";
      }
}
