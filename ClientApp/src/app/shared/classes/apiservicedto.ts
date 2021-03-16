import { RefreshAppDTO } from "./refresh-app-dto";

export class Apiservicedto {
    constructor(
        public url?: number,
        public custom_url?: string,
        public content?: string,
        public details?: RefreshAppDTO
      ) {
        this.url = 0;
        this.custom_url = "";
        this.content = "";
        this.details = new RefreshAppDTO();
       }
}
