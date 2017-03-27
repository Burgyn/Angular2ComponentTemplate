import { Component } from '@angular/core';

@Component({
    selector: '$componentFileName$',
    templateUrl: '$componentFileName$.component.html',
    styleUrls: [ '$componentFileName$.component.css'],
    moduleId: module.id
})
export class $componentName$Component {
    private name = '$componentName$Component';
}

// This code copy to app.module.ts
import { $componentName$Component$ } from './app/$componentFileName$.component';