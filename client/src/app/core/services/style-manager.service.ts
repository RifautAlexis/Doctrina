import { OverlayContainer } from '@angular/cdk/overlay';
import { HostBinding, Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';


/**
 * Class for managing stylesheets. Stylesheets are loaded into named slots so that they can be
 * removed or changed later.
 */
@Injectable()
export class StyleManagerService {
  private isDarkModeOn$: BehaviorSubject<boolean> = new BehaviorSubject(false);
  private themeClassName = "darkMode";
  private readonly pathToDarkTheme: string = "/assets/dark-theme.css";
  private readonly pathToLightTheme: string = "/assets/light-heme.css";
  @HostBinding('class') className = '';

  constructor(
    private overlay: OverlayContainer
  ) { }

  getIsDarkModeOn$(): Observable<boolean> {
    return this.isDarkModeOn$;
  }

  toggleTheme(isDarkModeOn: boolean): Observable<boolean> {
    if (this.overlay.getContainerElement().classList.contains("dark-theme")) {
      this.overlay.getContainerElement().classList.remove("dark-theme");
      this.overlay.getContainerElement().classList.add("light-theme");
    } else if (this.overlay.getContainerElement().classList.contains("light-theme")) {
      this.overlay.getContainerElement().classList.remove("light-theme");
      this.overlay.getContainerElement().classList.add("dark-theme");
    } else {
      this.overlay.getContainerElement().classList.add("light-theme");
    }
    if (document.body.classList.contains("dark-theme")) {
      document.body.classList.remove("dark-theme");
      document.body.classList.add("light-theme");
    } else if (document.body.classList.contains("light-theme")) {
      document.body.classList.remove("light-theme");
      document.body.classList.add("dark-theme");
    } else {
      document.body.classList.add("light-theme");
    }
    this.isDarkModeOn$.next(!isDarkModeOn);
    return this.isDarkModeOn$;
  }

  // changeTheme(isDarkModeOn: boolean) {
  //   this.className = isDarkModeOn ? this.themeClassName : '';
  //   // console.log("SERVICE => " + isDarkModeOn);
  //   if (isDarkModeOn) {
  //     console.log("ADD");
  //     this.overlay.getContainerElement().classList.add(this.themeClassName);
  //     this.isDarkModeOn$.next(!isDarkModeOn);
  //   } else {
  //     console.log("REMOVE");
  //     this.overlay.getContainerElement().classList.remove(this.themeClassName);
  //     this.isDarkModeOn$.next(!isDarkModeOn);
  //   }
  //   return this.isDarkModeOn$;
  // }

  // /**
  //  * Set the stylesheet with the specified key.
  //  */
  // setStyle(isDarkModeOn: boolean): Observable<boolean> {
  //   console.log("SET");
  //   this.removeStyle(isDarkModeOn);
  //   let pathToTheme: string;
  //   isDarkModeOn ? pathToTheme = this.pathToLightTheme : pathToTheme = this.pathToDarkTheme
  //   console.log(pathToTheme);
  //   getLinkElementForKey("themeAsset").setAttribute('href', pathToTheme);
  //   this.isDarkModeOn$.next(!isDarkModeOn);
  //   return this.isDarkModeOn$;
  // }

  // /**
  //  * Remove the stylesheet with the specified key.
  //  */
  // removeStyle(isDarkModeOn: boolean) {
  //   console.log("REMOVED");
  //   const existingLinkElement = getExistingLinkElementByKey("themeAsset");
  //   if (existingLinkElement) {
  //     document.head.removeChild(existingLinkElement);
  //   }
  //   this.isDarkModeOn$.next(isDarkModeOn);
  // }

  // setStyle(isDarkModeOn: boolean): Observable<boolean> {
  //   console.log("SET");
  //   // this.removeStyle(isDarkModeOn);
  //   const element = document.head.getElementsByTagName(`html`).item(0).setAttribute('id', "TEST");
  //   this.isDarkModeOn$.next(!isDarkModeOn);
  //   return this.isDarkModeOn$;
  // }
  
  // removeStyle(isDarkModeOn: boolean) {
  //   console.log("REMOVED");
  //   const existingLinkElement = getExistingLinkElementByKey("themeAsset");
  //   if (existingLinkElement) {
  //     document.head.removeChild(existingLinkElement);
  //   }
  //   this.isDarkModeOn$.next(isDarkModeOn);
  // }
}

function getLinkElementForKey(key: string) {
  return getExistingLinkElementByKey(key) || createLinkElementWithKey(key);
}

function getExistingLinkElementByKey(key: string) {
  // return document.head.querySelector(`#${key}`);
  return document.head.querySelector(`link[rel="stylesheet"].${getClassNameForKey(key)}`);
}

function createLinkElementWithKey(key: string) {
  const linkEl = document.createElement('link');
  // linkEl.setAttribute('id', key)
  linkEl.setAttribute('rel', 'stylesheet');
  linkEl.setAttribute('type', 'text/css');
  linkEl.classList.add(key);
  // linkEl.classList.add(getClassNameForKey(key));
  document.head.appendChild(linkEl);
  return linkEl;
}

function getClassNameForKey(key: string) {
  return `${key}`;
}